using ServiceLocator.Map;
using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Utilities;
using ServiceLocator.Wave;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameService : GenericMonoSingleton<GameService>
{


    public PlayerService playerService { get; private set; }
    public SoundService soundService { get; private set; }
    public MapService mapService { get; private set; }

    public WaveService waveService { get; private set; }

    

    [Header("PlayerService")]
    [SerializeField] PlayerScriptableObject playerScriptableObject;

    [Header("SoundService")]
    [SerializeField] AudioSource audioEffects;
    [SerializeField] AudioSource backgroundMusic;
    [SerializeField] SoundScriptableObject soundScriptableObject;
    
    [Header("UIService")]
    [SerializeField] UIService uiService;
    public UIService UIService => uiService;

    [Header("MapService")]
    [SerializeField] private MapScriptableObject mapScriptableObject;

    [Header("WaveService")]
    [SerializeField] private WaveScriptableObject waveScriptableObject;
    private void Start()
    {
        playerService = new PlayerService(playerScriptableObject);
        soundService = new SoundService(soundScriptableObject, audioEffects, backgroundMusic);
        mapService = new MapService(mapScriptableObject);
        waveService =new WaveService(waveScriptableObject);
       

    }
      
    private void Update()
    {
        playerService.Update();

       
    }


}
